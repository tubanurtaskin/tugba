# imagecompressor
 
This Python app made to automatically crop and compress the image downloaded from any website.

## Requirements
- A Python interpreter (made with 3.9 )
- Lots of love to Python
- Pillow library to process images
- PyQt for GUI (No need to use yet)

```shell
    pip install PyQt6
    pip install Pillow
```

## Notes
There is a conflict between PIL and Pillow. Need to use the same package.

## Ideas

- Simple terminal command can be used for fetching images
- Selenium can be used to upload photo for cropping and compressing. Not sure yet


## To-Do
- [ ] Crop image depends on its size. Different behaviour on portrait and landscape images
- [x] Compress image
- [x] Change image's extension if the image is in webp or different format and save it as JPEG
- [ ] Automatically fetch and process the image when URL is inserted
- [ ] Create UI with tkinter or Qt,PyQt
- [ ] Bundle the app with python package and pyqt (if needed) 
- [x] Batch process for images in the folder



