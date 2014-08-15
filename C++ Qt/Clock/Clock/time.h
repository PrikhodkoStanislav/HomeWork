#pragma once

#include <QtWidgets/QWidget>
#include <QtWidgets/QGraphicsItem>
#include <QtGui/QPainter>

class Time : public QGraphicsItem
{
public:
    Time();
    QRectF boundingRect() const override;
    QTime knowTime();
    QLineF lineSecond();
    QLineF lineMinute();
    QLineF lineHour();
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};
