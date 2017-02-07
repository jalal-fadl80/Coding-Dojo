$(document).ready(function () {



        $('button').click(function () {



            var firstname =$('#firstname').val();



            var lastname =$('#lastname').val();



            var desc = $('#desc').val();



            var carddata = "<div id='card'><p>" + firstname + " " + lastname

            + "<h4>click to flip me</h4></p>"

            + "<p id='back'>" + desc + "</p></div>";



            console.log(carddata)





            $("#right").append(carddata);

            //quotes, either single or double must match!

            return false;

        });

            $(document).on('click', '#card', function(){

                $(this).children().toggle();

            })



    }); // end of .ready
