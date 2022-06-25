let mongoose = require('mongoose');
let Quest = require('./schemas/questSchema');
let Race = require('./schemas/raceSchema');
let Skill = require('./schemas/skillSchema');

let characterSchema = new mongoose.Schema({
    userId :{
        type: String,
        require: true
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
    mp:Number,
    qp:Number,
    finishedQuests: [Quest],
    currentQuests: [Quest],
    race: Race,
    skills: [Skill]
});

module.exports = mongoose.model('Character', characterSchema);