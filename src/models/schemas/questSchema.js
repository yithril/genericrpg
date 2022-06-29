let mongoose = require('mongoose');

let questSchema = mongoose.Schema({
    description: {
        type: String,
        required: true
    },
    title: {
        type: String,
        required: true
    },
    points: Number,
    minLevel: Number,
    maxLevel: Number
});

module.exports = questSchema;