from PIL import Image
from src import cropper


def pngtojpg(filepath, outpath):
    im = Image.open(filepath)
    im = im.convert('RGB')
    cropper.imgcropper(filepath, outpath)

