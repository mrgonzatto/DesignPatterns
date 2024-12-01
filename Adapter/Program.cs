

void CenterRectangle(IRectangle rectangle)
{ 
    rectangle.Move(0, 0);
}

LegacyRectangle legacyRectangle = new LegacyRectangle(0, 0, 100, 50);

IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);

CenterRectangle(rectangle);