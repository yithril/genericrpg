const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

  const {
    getItems,
    getItem,
    createItem,
    updateItem,
    deleteItem,
} = require('../controllers/itemController');

router.route('/').get([checkJwt], getItems);

router.route('/:id').get([checkJwt], getItem);

router.route('/').post([checkJwt], createItem);

router.route('/:id').put([checkJwt], updateItem);

router.route('/:id').delete([checkJwt], deleteItem);

module.exports = router;

  