$(function () {
    $('button[data-category]').on('click', function () {
        var category = $(this).data('category');
        loadCategory(category);
    });
});

function loadCategory(category) {
    $.ajax({
        url: '/Store/Home/ProductGrid',
        data: { category: category },
        type: 'GET',
        success: function (result) {
            $('main').html(result);
            
            ViewBag.ShowCategoriesView = true;
        }
    });
}