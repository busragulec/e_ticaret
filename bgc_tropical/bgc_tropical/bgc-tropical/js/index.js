$('#nav-content').isotope({

});
$('#nav-filter').on('click','button',function(){
    var filterValue = $(this).attr('data-filter');
    $('#nav-content').isotope({filter: filterValue});
});