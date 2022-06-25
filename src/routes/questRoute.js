const express = require('express');
const router = express.Router();
const { auth, requiredScopes } = require('express-oauth2-jwt-bearer');
const checkJwt = auth({
    audience: 'https://genericrpg/api',
    issuerBaseURL: `https://dev-va9l1-67.us.auth0.com/`,
  });

  const {
    getQuests,
    getQuest,
    createQuest,
    updateQuest,
    deleteQuest,
} = require('../controllers/QuestController');

router.route('/').get([checkJwt], getQuests);

router.route('/:id').get([checkJwt], getQuest);

router.route('/').post([checkJwt], createQuest);

router.route('/:id').put([checkJwt], updateQuest);

router.route('/:id').delete([checkJwt], deleteQuest);

module.exports = router;

  