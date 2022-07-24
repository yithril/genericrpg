const mongoose = require('mongoose');
const Room = require('../models/room');

const getRooms = (req, res) => {
    Room.find()
    .then((allPC) => {
        return res.status(200).json({
            success: true,
            message: 'A list of all Rooms',
            Room: allPC,
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

const getRoom = (req, res) => {
    const id = req.params.id;

    Room.findById(id)
    .then((singleRoom) => {
        res.status(200).json({
            success: true,
            message: `Found skll`,
            Room: singleRoom,
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

const createRoom = (req, res) => {

   const room = new Room({
    _id: mongoose.Types.ObjectId(),
    shortDesc: req.body.shortDesc,
    longDesc: req.body.longDesc,
    zoneId: req.body.zoneId,
    isOutdoor: req.body.isOutdoor,
    xCoord: req.body.xCoord,
    yCoord: req.body.yCoord,
    zCoord: req.body.zCoord,
    terrain: req.body.terrain,
    roomExits: req.body.roomExits,
    startingItems: req.body.startingItems,
    startingNPCs: req.body.startingNPCs
   });

   return room
   .save()
   .then((newRoom) =>{
    return res.status(201).json({
        success:true,
        message: 'Created successfully',
        Room: newRoom
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

const updateRoom= (req, res) => {
    const id = req.params.id;

    const updateObject = req.body;

    Room.update({_id:id}, {$set:updateObject})
    .exec()
    .then(() => {
        res.status(200).json({
            success: true,
            message: 'Room is updated',
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

const deleteRoom = (req, res) => {
    const id = req.params.id;
    Room.findByIdAndRemove(id)
    .exec()
    .then(()=> res.status(204).json({
      success: true,
    }))
    .catch((err) => res.status(500).json({
      success: false,
    }));
};

module.exports = {
    getRooms,
    getRoom,
    createRoom,
    updateRoom,
    deleteRoom
}