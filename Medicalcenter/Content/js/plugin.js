 $(document).ready(function(){
    $("#owl-demo").owlCarousel({
        navigation : true, // Show next and prev buttons
        slideSpeed : 300,
        paginationSpeed : 400,
        singleItem:true,
        autoPlay : 5000,
        loop:true,
        stopOnHover : false,
        navigationText :false,
    });
    
    $("#owl-work").owlCarousel({
        autoPlay: 3000, //Set AutoPlay to 3 seconds
        items : 4,
        itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3]

    });
    $("#owl-client").owlCarousel({
        autoPlay: 4000, //Set AutoPlay to 3 seconds
        items : 4,
        itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3]

    });
     //nav
     $('.open-nav').click(function() {
        $('.nav-bar').css('left', '0');
        $(this).css('display','none');
    });
    $('.close-btn').click(function(){
        $('.nav-bar').css('left', '-250px');
        $('.open-nav').css('display','block')
    });
     	// hide #back-top first
	$("#scroll-top").hide();
	// fade in #back-top
	$(function () {
		$(window).scroll(function () {
			if ($(this).scrollTop() > 100) {
				$('#scroll-top').fadeIn();
			} else {
				$('#scroll-top').fadeOut();
			}
		});
		// scroll body to 0px on click
		$('#scroll-top button').click(function () {
			$('body,html').animate({
				scrollTop: 0
			}, 800);
		});
	});
 });
 $('.field-date').fdatepicker();
 