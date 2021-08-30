$(function(){
  $('.currency-wrapper').ready(function(){
      $.get('https://api.exchangeratesapi.io/latest?base=USD&symbols=RUB', function(response){
        $('.usd').html("<strong>USD</strong>: "+response.rates.RUB.toFixed(2) + " RUB");
                      
      });
      $.get('https://api.exchangeratesapi.io/latest?base=EUR&symbols=RUB', function(response){
        $('.eur').html("<strong>EUR</strong>: "+response.rates.RUB.toFixed(2) + " RUB");
                      
      });
  });
});

//$(function(){
//  $('a').click(function(){
//    return false;
//  });
//});