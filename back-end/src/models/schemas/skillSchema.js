let mongoose = require('mongoose');

let skillSchema = mongoose.Schema({
    name: {
        type: String,
        required: true
    },
    description: {
        type: String,
        required: true
    },
    isTrainable: Boolean,
    currentLevel: Number
});

module.exports = skillSchema;