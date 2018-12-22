/// <binding BeforeBuild='clean' AfterBuild='default' ProjectOpened='watch' />
//'use strict';

var lessFiles = 'styles/**/*.less';
var typescriptFiles = 'scripts/**/*.ts';
var cssFilesDest = 'wwwroot/css/';
var cssFiles = cssFilesDest + '**/*.css';
var jsFilesDest = 'wwwroot/js/';
var jsFiles = jsFilesDest + '**/*.js';


var gulp = require('gulp'),
    less = require("gulp-less"),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    lesshint = require('gulp-lesshint'),
    fs = require("fs"),
    uglify = require('gulp-uglify'),
    merge = require('merge-stream'),
    rename = require('gulp-rename'),
    del = require('del');

var tsProject;

gulp.task('less', function () {
    return gulp.src('styles/**/site.less')
        .pipe(lesshint({

        }))
        .pipe(lesshint.reporter())
        .pipe(lesshint.failOnError())
        .pipe(less())
        .pipe(gulp.dest(cssFilesDest + 'source'))
        .on('error', function (err) { console.log(err); });
});

gulp.task('min:css', function () {
    return gulp.src([cssFilesDest + '/source/**/*.css'])
        .pipe(concat('bundled.css'))
        .pipe(gulp.dest(cssFilesDest + 'bundled'))
        .pipe(rename('bundled.min.css'))
        .pipe(cssmin())
        .pipe(gulp.dest(cssFilesDest + 'minified'));
});

gulp.task("typescript", function () {
    var ts = require("gulp-typescript");
    var sourcemaps = require('gulp-sourcemaps');

    if (!tsProject) {
        tsProject = ts.createProject("tsconfig.json");
    }

    var reporter = ts.reporter.fullReporter();
    var tsResult = tsProject.src()
        .pipe(sourcemaps.init())
        .pipe(tsProject(reporter));

    return tsResult.js
        .pipe(sourcemaps.write())
        .pipe(gulp.dest("wwwroot/js"));
});

//gulp.task("min:js", function () {
//    return gulp.src(jsFiles)
//        .pipe(concat('bundle.js'))
//        .pipe(gulp.dest('.'))
//        .pipe(rename("all.min.js"))
//        .pipe(uglify())
//        .pipe(gulp.dest('.'));
//});

gulp.task('clean', () => {
    return del([jsFiles, cssFiles]);
});

gulp.task('watch', () => {
    gulp.watch(lessFiles, gulp.series(['less']));

    gulp.watch(cssFilesDest + 'source/**/*.css', gulp.series(['min:css']));

        //gulp.watch(cssFiles, gulp.series(['min:js']));


    gulp.watch(typescriptFiles, gulp.series(['typescript']));


});

gulp.task('default', gulp.series(['less', 'min:css', 'typescript']));