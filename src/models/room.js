let mongoose = require('mongoose');
let NPC = require('./schemas/npcSchema');
let Item = require('./schemas/itemSchema')

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
        room: String,
        direction: String
    }],
    startingItems: [Item],
    startingNPCs: [NPC]
});

module.exports = mongoose.model('Room', roomSchema);