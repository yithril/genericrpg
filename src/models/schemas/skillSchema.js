let mongoose = require('mongoose');

let skillSchema = mongoose.Schema({
    name: String,
    description: String,
    isTrainable: Boolean,
    currentLevel: Number
});

module.exports = skillSchema;