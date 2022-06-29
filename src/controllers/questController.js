const mongoose = require('mongoose');
const Quest = require('../models/quest');

const getQuests = (req, res) => {
    Quest.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all Quests',
            Quest: allPC,
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

const getQuest = (req, res) => {
    const id = req.params.id;

    Quest.findById(id)
    .then((singleQuest) => {
        res.status(200).json({
            success: true,
            message: `Found quest`,
            Quest: singleQuest,
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

const createQuest = (req, res) => {

   const quest = new Quest({
    _id: mongoose.Types.ObjectId(),
    description: req.body.description,
    title: req.body.title,
    points: req.body.points,
    minLevel: req.body.minLevel,
    maxLevel: req.body.maxLevel
   });

   return quest
   .save()
   .then((newQuest) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        Quest: newQuest
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

const updateQuest= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Quest.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'Quest is updated',
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

const deleteQuest = (req, res) => {
    const id = req.params.id;
    Quest.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getQuests,
    getQuest,
    createQuest,
    updateQuest,
    deleteQuest
}