<script>
    $(document).ready(function () {
        // Add click event listener to category buttons
        $('.dropdown-item').click(function () {
            var category = $(this).data('category');
            // Use Ajax to load the partial view
            $.ajax({
                url: '/Store/ProductGrid?category=' + category,
                type: 'GET',
                success: function (result) {
                    // Replace the main section with the loaded partial view
                    $('main').html(result);
                },
                error: function (xhr) {
                    alert('Error: ' + xhr.statusText);
                }
            });
        });
});
</script>