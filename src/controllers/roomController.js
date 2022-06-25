const mongoose = require('mongoose');
const Character = require('../models/room');

const getPlayercharacterByUserId = (req, res) => {
    const userId = req.params.id;

    Character.findOne({userId: userId})
        .then((pc) => {
            return res.status(200).json({
                success: true,
                message: 'Found pc',
                PC: pc
            });
        })
        .catch((err) => {
            res.status(500).json({
                success: false,
                message: 'Server error. Please try again.',
                error: err.message,
              });
        });
}

const getPlayerCharacters = (req, res) => {
    Character.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all pcs',
            PC: allPC,
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

const getPlayerCharacter = (req, res) => {
    const id = req.params.id;

    Character.findById(id)
    .then((singlePC) => {
        res.status(200).json({
            success: true,
            message: `Found pc`,
            Cause: singlePC,
          });
    })
    .catch((err) => {
        res.status(500).json({
            success: false,
            message: 'This pc does not exist',
            error: err.message,
          });
    });
};

const createPlayerCharacter = (req, res) => {
    console.log(req.body);
   const pc = new Character({
    _id: mongoose.Types.ObjectId(),
    userId: req.body.userId,
    name: req.body.name,
    level: req.body.level,
    strength: req.body.strength,
    constitution: req.body.constitution,
    dexterity: req.body.dexterity,
    intelligence: req.body.intelligence,
    perception: req.body.perception,
    charisma: req.body.charisma,
    xp: req.body.xp,
    hp: req.body.hp,
    mp: req.body.mp
   });

   return pc
   .save()
   .then((newPC) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        PC: newPC
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

const updatePlayerCharacter= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Character.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'PC is updated',
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

const deletePlayerCharacter = (req, res) => {
    const id = req.params.id;
    Character.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getPlayerCharacters,
    getPlayerCharacter,
    createPlayerCharacter,
    updatePlayerCharacter,
    deletePlayerCharacter,
    getPlayercharacterByUserId
}