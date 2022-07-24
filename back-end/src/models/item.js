let mongoose = require('mongoose');
let itemSchema = require('./schemas/itemSchema');
let weaponSchema = require('./schemas/weaponSchema');
let armorSchema = require('./schemas/armorSchema');

let item = mongoose.model('Item', itemSchema);
let Weapon = item.discriminator('Weapon', weaponSchema);
let Armor = item.discriminator('Armor', armorSchema);

module.exports = {
    item,
    Weapon,
    Armor
}