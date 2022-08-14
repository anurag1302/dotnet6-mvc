$(document).ready(() => {
    $('#btnSubmit').on('click', () => {
        $.ajax(
            {
                url: '/Product/AddProductUsingJQuery',
                type: 'POST',
                data: $('#ProductForm').serialize(),
                success: function (response) {
                    alert(response);
                },
                error: function (xhr) {
                    console.log(xhr);
                }
            }
        );
    });
});