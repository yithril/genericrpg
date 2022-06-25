let mongoose = require('mongoose');

let limbSchema = mongoose.Schema({
    name: String,
    canWield: Boolean,
    isVital: Boolean
});

module.exports = limbSchema;