function numbersOnly(arr) {

    //i tried to use arr.isArray here it did not work

    var newArray = [];

    for (var i = 0; i < arr.length; i++) {

        if (typeof arr[i] === "number") {

            newArray.push(arr[i]);

        }

    }

    return newArray; //I accidentally put this outside the function i needed it in there

}
