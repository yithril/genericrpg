let mongoose = require('mongoose');
let Skill = require('./skillSchema');
let Race = require('./raceSchema');

let NPCSchema = mongoose.Schema({
    name: String,
    shortDesc: String,
    longDesc: String,
    level: Number,
    strength: Number,
    constitution: Number,
    dexterity: Number,
    intelligence: Number,
    perception: Number,
    charisma:Number,
    hp:Number,
    mp:Number,
    skills: [Skill],
    race: Race,
    npcType: {
        type: String,
        enum: ['Quest', 'Priest', 'Shop', 'Inn', 'Trainer', 'None']
    },
    CR: Number
});

module.exports = NPCSchema;