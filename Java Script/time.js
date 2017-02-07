function time(hour, min, period) {



  if (hour < 13 && min < 61 && period == "am" || period == "pm") {    // note to self: first time i did this i accidentally assigned period to be am or pm by using only one "=" sign rather than using two to compare

    if (period == "am") {

      var phrase = " in the morning";

    }

    else {

      phrase = " in the evening"; //here i accidentally set var in front of phrase a second time- this created my bug where it only printed for in the evening.

    }

    if (min >= 50 && hour == 11 && period == "am") {

      console.log("it's almost noon");

    }

    else if (min >= 50 && hour == 11 && period == "pm"){//I neded to use else/if statement!!!

      console.log("It's almost midnight");

    }

    else if (min < 30) {

      console.log("Its just after " + hour + " " + period + phrase);

    }

    else {

      console.log("Its almost " + (hour + 1) + " " + period + phrase);

    }

  }

}

time(11, 55, "pm") 
