const buildFolder = `./wwwroot/content/`;
const srcFolder = `./wwwroot/src/`;

export const path = {
    build: {
        css: `${buildFolder}css/`,
    },
    src: {
        scss: `${srcFolder}scss/main.scss`,
    },
    watch: {
        scss: `${srcFolder}scss/**/*.scss`,
    },
    clean: buildFolder,
    buildFolder: buildFolder,
    srcFolder: srcFolder
};