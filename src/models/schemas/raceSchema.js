let mongoose = require('mongoose');
let Limb = require('./limbSchema');

let raceSchema = mongoose.Schema({
    name: String,
    isPlayable: Boolean,
    isPremium: Boolean,
    description: String,
    shortDescription: String,
    limbs: [Limb]
});

module.exports = raceSchema;