let mongoose = require('mongoose');
let options = { discriminatorKey: 'item' };

let itemSchema = mongoose.Schema({
    descripton: String,
    nounDescription: String,
    cost: Number,
    canTake: Boolean,
    secretDescription: String,
    hasSecret: Boolean,
    canTake: Boolean
},{
    options
});

module.exports = mongoose.model('Item', itemSchema);