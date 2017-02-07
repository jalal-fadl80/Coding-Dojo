var users = {

 'Students': [

     {first_name:  'Michael', last_name : 'Jordan'},

     {first_name : 'John', last_name : 'Rosales'},

     {first_name : 'Mark', last_name : 'Guillen'},

     {first_name : 'KB', last_name : 'Tonel'}

  ],

 'Instructors': [

     {first_name : 'Michael', last_name : 'Choi'},

     {first_name : 'Martin', last_name : 'Puryear'}

  ]

}

for (var category in users){

    console.log(category);

}

    for (var i = 0; i < users[category].length; i++){

        console.log(users[category][i]);

    }

    for (var person in users[category][i]){

    console.log(users[category][i][person]);

    }///
