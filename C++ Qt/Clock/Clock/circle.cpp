#include "circle.h"

Circle::Circle()
{
}

QRectF Circle::boundingRect() const
{
    return QRectF(0, 0, 300, 300);
}

void Circle::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawEllipse(boundingRect());
}
