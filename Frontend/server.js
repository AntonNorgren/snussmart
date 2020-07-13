const express = require('express')
const app = express();
const path = require('path');

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname + '/index.html'));
});

app.get('/snus/:snusId', function (req, res) {
    // res.send(req.params)
    res.sendFile(path.join(__dirname + '/specific-snuff.html'));
});

app.listen(8000, () => {
    console.log('Example app listening on port 8000!')
});
