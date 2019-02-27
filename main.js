$(document).ready(function() {

	var paises = [];
	var idiomas = [];
	var map = new Map();
	$.getJSON( "countries.json", function( json ) {
	  	
	  	$.each(json,function(index, item){
	  		map.set(item.name,item.languages);
	  		
	  	})

	  	for(var key of map.keys()){
	  		paises.push(key);
	  	}
	  	console.log(paises)
	  	$( "#paises" ).autocomplete({
	      	source: paises
	    });
	});
	

	

    $("#paises").focusout(function(){
    	var pais =$("#paises").val();
    	var paisMapa = map.get(pais);
    	console.log(paisMapa);
    	$('#idiomas').html('');
    	for(var idioma of paisMapa){
    	$('#idiomas').append(`<option>${idioma}</option>`)

    	}	
    	
    })


    $("input[type='radio']").click(function(){

      var radioValue = $("input[name='radio-group']:checked").val();

      if(radioValue=="Casado"){
      	  $('#otroDisplay').css('display','none');
          $('#hijosDisplay').css('display','inline-block');
      }else if(radioValue=="Otro"){
      	  $('#hijosDisplay').css('display','none');
          $('#otroDisplay').css('display','inline-block');

      }else{
      	  $('#otroDisplay').css('display','none');
      	  $('#hijosDisplay').css('display','none');
      }
    
  });
});

