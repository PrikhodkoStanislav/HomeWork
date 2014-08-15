#include "circle.h"
#include <QtMath>

Circle::Circle()
{
}

QRectF Circle::boundingRect() const
{
    return QRectF(0, 0, 300, 300);
}

QLineF Circle::line0()
{
    return QLineF(150, 0, 150, 5);
}

QLineF Circle::line5()
{
    double alpha = - 3.14 / 3;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line10()
{
    double alpha = - 3.14 / 6;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line15()
{
    return QLineF(295, 150, 300, 150);
}

QLineF Circle::line20()
{
    double alpha = 3.14 / 6;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line25()
{
    double alpha = 3.14 / 3;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line30()
{
    return QLineF(150, 295, 150, 300);
}

QLineF Circle::line35()
{
    double alpha = 2 * 3.14 / 3;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line40()
{
    double alpha = 5 * 3.14 / 6;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line45()
{
    return QLineF(0, 150, 5, 150);
}

QLineF Circle::line50()
{
    double alpha = - 5 * 3.14 / 6;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

QLineF Circle::line55()
{
    double alpha = - 2 * 3.14 / 3;
    double x1 = 150 * cos(alpha) - 0 * sin(alpha) + 150;
    double y1 = 150 * sin(alpha) + 0 * cos(alpha) + 150;
    double x2 = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    double y2 = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(x1, y1, x2, y2);
}

void Circle::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawEllipse(boundingRect());
    painter->drawLine(line0());
    painter->drawLine(line5());
    painter->drawLine(line10());
    painter->drawLine(line15());
    painter->drawLine(line20());
    painter->drawLine(line25());
    painter->drawLine(line30());
    painter->drawLine(line35());
    painter->drawLine(line40());
    painter->drawLine(line45());
    painter->drawLine(line50());
    painter->drawLine(line55());
}
