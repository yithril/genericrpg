const mongoose = require('mongoose');
const Race = require('../models/Race');

const getRaces = (req, res) => {
    Race.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all Races',
            Race: allPC,
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

const getRace = (req, res) => {
    const id = req.params.id;

    Race.findById(id)
    .then((singleRace) => {
        res.status(200).json({
            success: true,
            message: `Found skll`,
            Race: singleRace,
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

const createRace = (req, res) => {

   const race = new Race({
    _id: mongoose.Types.ObjectId(),
    name: req.body.name,
    isPlayable: req.body.isPlayable,
    isPremium: req.body.isPremium,
    description: req.body.description,
    shortDescription: req.body.shortDescription,
    limbs: req.body.limbs
   });

   return race
   .save()
   .then((newRace) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        Race: newRace
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

const updateRace= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Race.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'Race is updated',
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

const deleteRace = (req, res) => {
    const id = req.params.id;
    Race.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getRaces,
    getRace,
    createRace,
    updateRace,
    deleteRace
}