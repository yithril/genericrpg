let options = { discriminatorKey: 'item' };
let mongoose = require('mongoose');

let itemSchema = mongoose.Schema({
    descripton: {
        type: String,
        required: true
    },
    nounDescription: {
        type: String,
        required: true
    },
    cost: Number,
    canTake: Boolean,
    secretDescription: String,
    hasSecret: Boolean,
    canTake: Boolean,
    isMagical: Boolean,
    isLegendary: Boolean
},{
    options
});

module.exports = itemSchema;