const mongoose = require('mongoose');
const Item = require('../models/Item');

const getItems = (req, res) => {
    Item.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all Items',
            Item: allPC,
          });
    })
    .catch((err) => {
        res.status(500).json({
          success: false,
          message: 'Server error. Please try again.',
          error: err.message,
        });
      });
};

const getItem = (req, res) => {
    const id = req.params.id;

    Item.findById(id)
    .then((singleItem) => {
        res.status(200).json({
            success: true,
            message: `Found skll`,
            Item: singleItem,
          });
    })
    .catch((err) => {
        res.status(500).json({
            success: false,
            message: 'This does not exist',
            error: err.message,
          });
    });
};

const createItem = (req, res) => {

   const item = new Item({
    _id: mongoose.Types.ObjectId(),
    descripton: req.body.descripton,
    nounDescription: req.body.nounDescription,
    cost: req.body.cost,
    canTake: req.body.canTake,
    secretDescription: req.body.secretDescription,
    hasSecret: req.body.hasSecret,
    canTake: req.body.canTake,
    isMagical: req.body.isMagical,
    isLegendary: req.body.isLegendary
   });

   return item
   .save()
   .then((newItem) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        Item: newItem
    })
   })
   .catch((error) => {
    res.status(500).json({
        success: false,
        message: 'Server error',
        error:error.message
    })
   });
};

const updateItem= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Item.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'Item is updated',
            updateCause: updateObject,
          });
    })
    .catch((err) => {
        res.status(500).json({
            success: false,
            message: 'Server error. Please try again.'
          });
    });
};

const deleteItem = (req, res) => {
    const id = req.params.id;
    Item.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getItems,
    getItem,
    createItem,
    updateItem,
    deleteItem
}