$(document).ready(() => {
    $('#btnSubmit').on('click', () => {
        $('span').text('');
        $.ajax(
            {
                url: '/Product/AddProductUsingJQuery',
                type: 'POST',
                data: $('#ProductForm').serialize(),
                success: function (response) {
                    console.log(response);
                },
                error: function (xhr) {
                    console.log(xhr.responseJSON);
                    $.each(xhr.responseJSON, function (index, err) {
                        $('span[data-valmsg-for="' + err.key + '"]').text(err.errorMessages[0]);
                    });
                }
            }
        );
    });
});