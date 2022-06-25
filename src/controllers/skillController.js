const mongoose = require('mongoose');
const Skill = require('../models/skill');

const getSkills = (req, res) => {
    Skill.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all skills',
            Skill: allPC,
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

const getSkill = (req, res) => {
    const id = req.params.id;

    Skill.findById(id)
    .then((singleSkill) => {
        res.status(200).json({
            success: true,
            message: `Found skll`,
            Skill: singleSkill,
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

const createSkill = (req, res) => {

   const skill = new Skill({
        name: req.body.name,
        description: req.body.description,
        isTrainable: req.body.isTrainable,
        currentLevel: req.body.currentLevel
   });

   return skill
   .save()
   .then((newSkill) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        Skill: newSkill
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

const updateSkill= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Skill.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'Skill is updated',
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

const deleteSkill = (req, res) => {
    const id = req.params.id;
    Skill.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getSkills,
    getSkill,
    createSkill,
    updateSkill,
    deleteSkill
}