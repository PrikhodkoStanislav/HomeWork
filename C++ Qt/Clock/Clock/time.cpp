#include "time.h"
#include <QTime>
#include <QtMath>

Time::Time()
{
}

QRectF Time::boundingRect() const
{
    return QRectF(0, 0, 300, 300);
}

QTime Time::knowTime()
{
    QTime *time = new QTime;
    QTime realTime = time->currentTime();
    delete time;
    return realTime;
}

QLineF Time::lineSecond()
{ 
    double realSecond = Time::knowTime().second();
    double realAngle = 3.14 * realSecond / 30;
    double alpha = - 3.14 / 2 + realAngle;
    int x = 135 * cos(alpha) - 0 * sin(alpha) + 150;
    int y = 135 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

QLineF Time::lineMinute()
{
    double realMinute = knowTime().minute();
    double realAngle = 3.14 * realMinute / 30;
    double alpha = - 3.14 / 2 + realAngle;
    int x = 145 * cos(alpha) - 0 * sin(alpha) + 150;
    int y = 145 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

QLineF Time::lineHour()
{
    double realHour = knowTime().hour();
    double realAngle = 3.14 * realHour / 6;
    double alpha = - 3.14 / 2 + realAngle;
    int x = 115 * cos(alpha) - 0 * sin(alpha) + 150;
    int y = 115 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

void Time::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawLine(lineSecond());
    painter->drawLine(lineMinute());
    painter->drawLine(lineHour());
}
