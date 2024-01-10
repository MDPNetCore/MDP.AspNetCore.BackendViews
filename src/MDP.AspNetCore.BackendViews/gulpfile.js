// variables
var libraryList = [
    { name: "bootstrap", path: "./node_modules/bootstrap/dist/**/", src: ["*.css*", "*.js*"] },
    { name: "bootstrap-icons", path: "./node_modules/bootstrap-icons/**/", src: ["*.css*", "*.woff*"] },
    { name: "@popperjs", path: "./node_modules/@popperjs/core/dist/**/", src: ["*.js*"] }
];

// require
var gulp = require("gulp");
var rimraf = require("rimraf");
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var cssnano = require('gulp-cssnano');

// task
gulp.task("lib-clean", function (cb) {
	
	// delete
    rimraf("./wwwroot/lib", cb);
});

gulp.task("lib-copy", function (done) {
	
	// copy
    libraryList.forEach(function (library) {
        library.src.forEach(function (src) {
            gulp.src(library.path + src).pipe(gulp.dest("./wwwroot/lib/" + library.name));
        });
    });
	
	// done
    done();
});

gulp.task("lib-build", function (done) {
	
	// css
    gulp.src('./css/*.css')
        .pipe(concat('mdp-backend-views.min.css'))
        .pipe(cssnano()) 
        .pipe(gulp.dest('./wwwroot/lib/mdp-backend-views/css'));

    // js
    gulp.src('./js/*.js')
        .pipe(concat('mdp-backend-views.min.js'))
        .pipe(uglify()) 
        .pipe(gulp.dest('./wwwroot/lib/mdp-backend-views/js'));

    // img
    gulp.src('./img/**/*')
        .pipe(gulp.dest('./wwwroot/lib/mdp-backend-views/img'));

    // done
    done();
});

gulp.task("publish", gulp.series("lib-clean", "lib-copy", "lib-build"));