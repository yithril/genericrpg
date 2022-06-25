let mongoose = require('mongoose');

let characterSchema = new mongoose.Schema({
    userId: {
        type: String,
        required: true
    },
    name: String,
    level: Number,
    strength: Number,
    constitution: Number,
    dexterity: Number,
    intelligence: Number,
    perception: Number,
    charisma:Number,
    xp:Number,
    hp:Number,
    mp:Number
});

module.exports = mongoose.model('Character', characterSchema);