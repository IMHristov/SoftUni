const path = require('path');

module.exports = {
    rootFolder: path.normalize(path.join(__dirname, '/../')),
    database:{
        "development": {
            "username": "root",
            "password": "0525",
            "database": "blog",
            "host": "127.0.0.1",
            "dialect": "mysql",
            "logging": false
        },
    }
};

