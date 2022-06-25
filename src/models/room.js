let mongoose = require('mongoose');
let NPC = require('./schemas/');

let roomSchema = mongoose.Schema({
    shortDesc: String,
    longDesc: String,
    zoneId: String,
    isOutdoor: Boolean,
    xCoord: Number,
    yCoord: Number,
    zCoord: Number,
    terrain: {
        type: String,
        enum: ['grassland', 'swamp', 'mountains', 'air', 'city', 'hills']
    },
    roomExits: [{
        type: String
    }],
    startingItems: [{
        type: String
    }],
    startingNPCs: [{
        type: String
    }]
});

module.exports = mongoose.model('Room', roomSchema);