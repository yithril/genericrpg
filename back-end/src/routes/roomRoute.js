const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

  const {
    getRooms,
    getRoom,
    createRoom,
    updateRoom,
    deleteRoom,
} = require('../controllers/roomController');

router.route('/').get([checkJwt], getRooms);

router.route('/:id').get([checkJwt], getRoom);

router.route('/').post([checkJwt], createRoom);

router.route('/:id').put([checkJwt], updateRoom);

router.route('/:id').delete([checkJwt], deleteRoom);

module.exports = router;

  