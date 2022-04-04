import gulp from "gulp";

import { path } from "./wwwroot/gulp/config/path.js";

global.app = {
    path: path,
    gulp: gulp
}

import { reset } from "./wwwroot/gulp/tasks/reset.js";
import { scss } from "./wwwroot/gulp/tasks/scss.js";

//const test = gulp.series(reset, copy);
function watcher() {
    gulp.watch(path.watch.scss, scss);
}

const dev = gulp.series(reset, scss, watcher);
gulp.task('default', dev);