// JavaScript source code
/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {

    if (x < 0) {
        return false;
    }

    let lengthOf = x.toString().length;
    let array = [];
    for (var i = 0; i < lengthOf; i++) {
        array.push(x % 10);
        x = Math.floor(x / 10);
    }
    let backwardsArray = [];
    let counter = 0;

    for (var i = array.length - 1; i > -1; i--) {
        backwardsArray[counter] = array[i];
        counter++;
    }

    for (let i = 0; i < array.length; i++) {
        if (array[i] !== backwardsArray[i]) {
            return false;
        }
        else {

            return true;
        }
    }
};
