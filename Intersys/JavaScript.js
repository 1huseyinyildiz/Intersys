
//9.Optional Power

function optionalPow(a, b) {
    var result;
    var userChoice = confirm("Do you want to raise " + a + " to the power of " + b + "?");
    if (userChoice) {
        result = Math.pow(a, b);
    } else {
        result = Math.pow(b, a);
    } 
    return result;
}


//10.Fix age

function fixage(ages) {
    var validAges = [];
    for (var i = 0; i < ages.length; i++) {
        if (ages[i] >= 18 && ages[i] <= 60) {
            validAges.push(ages[i]);
        }
    }
    if (validAges.length === 0) {
        return "NA";
    }
    return validAges.join(",");
}

//11.Common Digit

function mostOccurringDigit(N, arr) {
    let digitCount = new Array(10).fill(0);
    for (let i = 0; i < N; i++) {
        let num = arr[i];
        while (num > 0) {
            let digit = num % 10;
            digitCount[digit]++;
            num = Math.floor(num / 10);
        }
    }
    let maxCount = -1;
    let maxDigit = -1;
    for (let i = 0; i < 10; i++) {
        if (digitCount[i] > maxCount) {
            maxCount = digitCount[i];
            maxDigit = i;
        }
    }
    return maxDigit;
}


//12.Digit Sum

function maxDigitSum(n, arr) {
    let maxSum = -1;
    let maxIndex = -1;
    for (let i = 0; i < n; i++) {
        let current = arr[i];
        let sum = 0;
        while (current > 0) {
            sum += current % 10;
            current = Math.floor(current / 10);
        }
        if (sum > maxSum) {
            maxSum = sum;
            maxIndex = i;
        }
    }
    return maxIndex;
}

const n = 3;
const arr = [2, 4, 3];
console.log(maxDigitSum(n, arr));

