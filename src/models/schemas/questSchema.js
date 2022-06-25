let mongoose = require('mongoose');

let questSchema = mongoose.Schema({
    description: String,
    title: String,
    points: Number,
    minLevel: Number,
    maxLevel: Number
});

module.exports = questSchema;