$(function () {
    // app.initialize();

    // Activate Knockout
    // ko.validation.init({ grouping: { observable: false } });
    if (todoApp && todoApp.todoViewModel)
        ko.applyBindings(todoApp.todoViewModel);
});
