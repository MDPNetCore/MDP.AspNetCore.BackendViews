// variables
var libraryList = [
    { name: "bootstrap", path: "./node_modules/bootstrap/dist/**/", src: ["*.css*", "*.js*"] },
    { name: "bootstrap-icons", path: "./node_modules/bootstrap-icons/**/", src: ["*.css*", "*.woff*"] },
    { name: "@popperjs", path: "./node_modules/@popperjs/core/dist/**/", src: ["*.js*"] },
];

// require
var gulp = require("gulp");
var rimraf = require("rimraf");

// task
gulp.task("lib-clean", function (cb) {
    rimraf("./wwwroot/lib/bootstrap", cb);
    rimraf("./wwwroot/lib/bootstrap-icons", cb);
    rimraf("./wwwroot/lib/@popperjs", cb);
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