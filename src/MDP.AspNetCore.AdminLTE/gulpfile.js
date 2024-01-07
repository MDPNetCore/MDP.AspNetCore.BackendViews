// variables
var libraryList = [
    { name: "jquery", path: "./node_modules/jquery/dist/**/", src: ["*.js*"] },
    { name: "bootstrap", path: "./node_modules/bootstrap/dist/**/", src: ["*.css*", "*.js*"] },
    { name: "admin-lte", path: "./node_modules/admin-lte/dist/**/", src: ["*.css*", "*.js*", "*.png", "*.jpg"] },
    { name: "fontawesome-free", path: "./node_modules/@fortawesome/fontawesome-free/**/", src: ["*.css*", "*.js*"] },
    { name: "fontawesome-free", path: "./node_modules/@fortawesome/fontawesome-free/*webfonts*/", src: ["*"] }
];

// require
var gulp = require("gulp");
var rimraf = require("rimraf");

// task
gulp.task("lib-clean", function (cb) {
    rimraf("./wwwroot/lib/jquery", cb);
    rimraf("./wwwroot/lib/bootstrap", cb);
    rimraf("./wwwroot/lib/admin-lte", cb);
    rimraf("./wwwroot/lib/fontawesome-free", cb);
});

gulp.task("lib-copy", function (done) {
    libraryList.forEach(function (library) {
        library.src.forEach(function (src) {
            gulp.src(library.path + src).pipe(gulp.dest("./wwwroot/lib/" + library.name));
        });
        done();
    });
});

gulp.task("publish", gulp.series("lib-clean", "lib-copy"));