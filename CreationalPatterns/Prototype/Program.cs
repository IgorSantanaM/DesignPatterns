﻿using Prototype;

var rectangle = new Rectangle(width: 100, height: 100, Color.LightGray);

void CopyDrag(IShape shape)
{
    var newShape = shape.Clone();

}