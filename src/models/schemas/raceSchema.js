let mongoose = require('mongoose');
let Limb = require('./limbSchema');

let raceSchema = mongoose.Schema({
    name: {
        type: String,
        required: true
    },
    isPlayable: Boolean,
    isPremium: Boolean,
    description: {
        type: String,
        required: true
    },
    shortDescription: {
        type: String,
        required: true
    },
    limbs: [Limb]
});

module.exports = raceSchema;