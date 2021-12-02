$(document).ready(function() {
	var thisValue = 0;
	var valueOne = 0;
	var valueTwo = 0;

	$('.x1').click(function(event) {
		$(".symble").css({"pointer-events":"auto"})
		if($('.x1').hasClass('first-active')){
			thisValue = $(this).text();
			$('.valueOne').append(thisValue);
			valueOne = $('.valueOne').text();
		}else if($('.x1').hasClass('second-active')){
			thisValue = $(this).text();
			$('.valueTwo').append(thisValue);
			valueTwo = $('.valueTwo').text();
		}
	});
	
	$('.symble').click(function(){
		symble = $(this).html();
		$('.valueSymble').text(symble);
		symble = $('.valueSymble').text();
		$('.x1').removeClass('first-active').addClass('second-active')
	})

	$("#equal").click(function(){
		valueOne = parseFloat(valueOne);
		valueTwo = parseFloat(valueTwo);
		if(symble == "+"){
			valueOne += valueTwo
		}else if(symble == "-"){
			valueOne -= valueTwo
		}else if(symble == "×"){
			valueOne = valueOne * valueTwo
		}else if(symble == "÷"){
			valueOne = valueOne / valueTwo
		}

	$('.valueOne').text(valueOne);
	$('.valueSymble').text('');
	$('.valueTwo').text('');

	})

	$("#cancel").click(function(){
		$('.x1').addClass('first-active');
		$('.symble').css({"pointer-events":"none"});
		$('.valueOne').text('');
		$('.valueSymble').text('');
		$('.valueTwo').text('');
	})

});
