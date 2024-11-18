# JsonTemplating

I created this sample project to explore using text templating libraries to, at
runtime render large json files out of smaller json snippets.

The following project showcases this functionality through the use of the
[DotLiquid](https://github.com/dotliquid/dotliquid) templating library.

Take a look at the `schema<x>.json` files defined in `JsonTemplating/Schemas/` folder
of this project for more information on how these files can constructed using
this library.

* [schema1.json](JsonTemplating/Schemas/schema1.json): hardcoded json file, no templating
* [schema2.json](JsonTemplating/Schemas/schema2.json): includes multiple partial snippets to make 1:1 example of schema1.json
* [schema3.json](JsonTemplating/Schemas/schema3.json): builds a bigger json with multiple layers of includes of partial snippets.
* [schema4.json](JsonTemplating/Schemas/schema4.json): build a schema with repeated snippets of text inside of an object.
