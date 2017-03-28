$(function() {
    $("#getComments").click(function() {
        viewModel.comments([]);

        $.get('/api/comments', function(data) {
            viewModel.comments(data);
        });
    });
});