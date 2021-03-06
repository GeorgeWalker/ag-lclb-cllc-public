// Karma configuration file, see link for more information
// https://karma-runner.github.io/1.0/config/configuration-file.html

module.exports = function(config) {
  config.set({
    basePath: "",
    singleRun: true,
    frameworks: ["jasmine", "@angular-devkit/build-angular"],
    plugins: [
      require("karma-jasmine"),
      require("karma-chrome-launcher"),
      require("karma-htmlfile-reporter"),
      require("karma-junit-reporter"),
      require("karma-coverage-istanbul-reporter"),
      require("@angular-devkit/build-angular/plugins/karma")
    ],
    client: {
      clearContext: false // leave Jasmine Spec Runner output visible in browser
    },
    coverageIstanbulReporter: {
      dir: require("path").join(__dirname, "coverage"),
      reports: ["html", "lcovonly"],
      fixWebpackSourcePaths: true
    },
    reporters: ["progress", "html", "junit"],
    htmlReporter: {
      outputFile: "unit-tests.html",
      pageTitle: "Unit Tests",
      subPageTitle: "Portal tests",
      groupSuites: true,
      useCompactStyle: true,
      useLegacyStyle: true
    },
    junitReporter: {
      outPutDir: __dirname,
      outputFile: "junit.xml",
      useBrowserName: false
    },

    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ["ChromeHeadlessNoSandbox"],
    customLaunchers: {
      ChromeHeadlessNoSandbox: {
        base: "ChromeHeadless",
        flags: [
          "--no-sandbox", // required to run without privileges in docker
          "--user-data-dir=/tmp/chrome-test-profile",
          "--disable-web-security"
        ]
      }
    },
    singleRun: false
  });
};
