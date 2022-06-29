let mongoose = require('mongoose');

let limbSchema = mongoose.Schema({
    name: {
        type: String,
        required: true
    },
    canWield: Boolean,
    isVital: Boolean
});

module.exports = limbSchema;