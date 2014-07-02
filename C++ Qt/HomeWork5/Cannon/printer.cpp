#include "printer.h"

Printer::Printer()
{
}

QRectF Printer::boundingRect() const
{
    return QRectF(0, 0, 200, 200);
}

void Printer::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawPie(boundingRect(), 0, 1435);
}
