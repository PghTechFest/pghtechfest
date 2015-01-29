﻿<!-- *** WELCOME STARTS *** -->
<div id="welcome">
	<div class="container">
		<div class="row">
			<div class="col-md-12">
				<div class="logo_welcome">
					<h1 class="title">Venue</h1>
				</div>
				<div class="welcome-text">
					
					<p>
						<div class="map_wrap" >
							<iframe style="height:300px;width:800px;margin-bottom:20px;margin-left:-30px;" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=La+Roche+College+9000+Babcock+Boulevard+Pittsburgh,+PA+15237&amp;t=m&amp;z=14&amp;iwloc=near&amp;output=embed"></iframe>
						</div>
					</p>
					
					<p><a href="http://www.laroche.edu/about-LRC/directions.asp" target="_blank">La Roche College</a> 
						is located in the North Hills suburbs of Pittsburgh.</p>
					<p>Address: <strong>9000 Babcock Blvd. Pittsburgh, PA 15237</strong><br/>
					<a href="http://www.laroche.edu/about-LRC/directions.asp" target="_blank">Click here</a> for directions to the campus.</p>

					<p>Once on campus, we will be in the Zappala College Center, building 3. Check it out on the <a href="http://www.laroche.edu/tour/la%20roche%20campus%20map.pdf?vhost=laroche&vhostT=&vhostStyle=" target="_blank">campus map</a>.</p>
					<p>Phone: <strong>(412) 367-9300</strong></p>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- *** WELCOME END *** --> 

@section page_scripts
{
    $('#top_menu').addClass('dark_menu');
    $('#top_menu').removeClass('transparent_menu');
    $('#logo_dark').html('<img src="~/content/images/logo.png" alt="logo">');
}
