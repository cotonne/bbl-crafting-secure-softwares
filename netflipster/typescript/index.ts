#!/usr/bin/env node
var rl = require('readline-sync');
var sqlite3 = require('sqlite3').verbose();
var db = new sqlite3.Database(':memory:');

import * as init from 'db/init';
import * as users from 'db/users';
import * as dvds from 'db/dvds';
import * as bookings from 'db/bookings';

init.init(db);

console.log('Registration ---- ');
console.log('Identifier: ');
let newUserId: string = rl.prompt();
console.log('Password: ');
let newPassword = rl.prompt();
register(newUserId, newPassword);
let userId:string;

users.register(db, newUserId, newPassword)
  .then(() => {
    console.log('Connection ---- ');
    console.log('Identifier: ');
    userId = rl.prompt();
    console.log('Password: ');
    let password = rl.prompt();
    return login(userId, password);
  })
  .then(() => {
    console.log('Films ---- ');
    // List DVD HERE
    // Format
    // dvdId) dvdName
  
    console.log('Selection: ');
    let dvdId = rl.prompt();
    console.log('Quantity: ');
    let quantity = parseInt(rl.prompt());
    booking(dvdId, quantity, userId);
  });


function register(userId: string, password: String): Promise<{}>{
  return new Promise((resolve) => resolve());
}

function login(userId: string, password: String):  Promise<boolean>{
  return new Promise((resolve) => resolve(true));
}

function booking(dvdId: string, quantity: number, userId: string) {
  return new Promise((resolve) => resolve());
}

